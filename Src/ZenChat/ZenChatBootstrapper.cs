﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Reflection;
using System.Windows;
using Caliburn.Micro;
using ZenChat.ViewModels;

namespace ZenChat
{
    public class ZenChatBootstrapper : BootstrapperBase
    {
        private CompositionContainer container;

        public ZenChatBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            container = new CompositionContainer(
                new AggregateCatalog(
                    AssemblySource.Instance.Select(x => new AssemblyCatalog(x)).OfType<ComposablePartCatalog>()
                )
            );

            CompositionBatch batch = new CompositionBatch();

            batch.AddExportedValue<IWindowManager>(new WindowManager());
            batch.AddExportedValue<IEventAggregator>(new EventAggregator());
            batch.AddExportedValue(container);

            container.Compose(batch);
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            string contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(serviceType) : key;
            IEnumerable<object> exports = container.GetExportedValues<object>(contract);

            if (exports.Any())
                return exports.First();

            throw new Exception(string.Format("Could not locate any instances of contract {0}.", contract));
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return container.GetExportedValues<object>(AttributedModelServices.GetContractName(serviceType));
        }

        protected override void BuildUp(object instance)
        {
            container.SatisfyImportsOnce(instance);
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            List<Assembly> assemblies = base.SelectAssemblies().ToList();
            Assembly moduleAssembly = Assembly.LoadFrom("ZenChat.Module.dll");
            assemblies.Add(moduleAssembly);
            return assemblies;
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            this.DisplayRootViewFor<MainWindowViewModel>();
        }
    }
}