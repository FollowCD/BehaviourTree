using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourTree
{
    public class BehaviourNode
    {
        //父节点
        protected BehaviourNode parent;
        //子节点
        protected List<BehaviourNode> children = new List<BehaviourNode>();
        //外部前提
        protected BevNodePrecondition m_NodePrecondition;

        /// <summary>
        /// 评估是否执行该节点
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool Evaluate(ref BevNodeInputParam input)
        {
            return (m_NodePrecondition == null || m_NodePrecondition.ExternalCondition(ref input) && DoEvaluate(ref input));
        }

        //节点内部评估条件
        protected virtual bool DoEvaluate(ref BevNodeInputParam input)
        {
            return true;
        }

        /// <summary>
        /// 从上一个运行的节点切换到下一个节点，这时执行运行节点的
        /// 这个方法，所以这个方法类似于状态机的OnExit()方法。
        /// </summary>
        /// <param name="input"></param>
        public void Transition(ref BevNodeInputParam input)
        {
            DoTransition(ref input);
        }

        /// <summary>
        /// 实际执行的切换方法，子类覆写
        /// </summary>
        /// <param name="input"></param>
        protected virtual void DoTransition(ref BevNodeInputParam input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新方法，类似于Mono的Update()
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        BevRunningStatus Tick(ref BevNodeInputParam input,ref BevNodeOutputParam output)
        {
            return DoTick(ref input, ref output);
        }

        private BevRunningStatus DoTick(ref BevNodeInputParam input, ref BevNodeOutputParam output)
        {
            throw new NotImplementedException();
        }

        
    }
}
