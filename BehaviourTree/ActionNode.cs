using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourTree
{
    public class ActionNode:BehaviourNode
    {
        protected virtual void DoEnter(ref BevNodeInputParam input) { }
        protected virtual BevRunningStatus DoExcute(ref BevNodeInputParam input,BevNodeOutputParam output) { throw new NotImplementedException(); }
        protected virtual void DoExit(ref BevNodeInputParam input,BevRunningStatus status) { }
    }
}
