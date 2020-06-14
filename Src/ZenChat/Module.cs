using System.ComponentModel.Composition;

namespace ZenChat
{
    /// <summary>
    /// 模块抽象基类
    /// </summary>
    [InheritedExport]
    public abstract class Module
    {
        public abstract string Name { get; }

        public abstract string Desc { get; }
    }

}