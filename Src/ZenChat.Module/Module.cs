using System.ComponentModel.Composition;

namespace ZenChat.Module
{
    /// <summary>
    /// 左侧模块抽象基类
    /// </summary>
    [InheritedExport]
    public abstract class Module
    {
        public abstract string Name { get; }

        public abstract string Desc { get; }
    }

}