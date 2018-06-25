using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourTree
{
    public enum ReturnType
    {
        Running,
        Success,
        Failed,
    }

    public enum NodeType
    {
        RootNode,//主节点
        CompositeNode,//复合节点
        CompositeSelectorNode,//复合选择节点
        CompositeSequenceNode,//复合队列节点
        CompositeParallelNode,//复合并行节点
        DecoratorNode,//装饰节点
        ConditionNode,//条件节点
        ActionNode,//动作节点
    }
}
