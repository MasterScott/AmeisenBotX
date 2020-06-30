﻿using AmeisenBotX.BehaviorTree.Enums;
using System;
using System.Collections.Generic;

namespace AmeisenBotX.BehaviorTree.Objects
{
    public class Selector<T> : Composite<T>
    {
        public Selector(Func<T, bool> condition, Node<T> nodeA, Node<T> nodeB) : base("")
        {
            Condition = condition;
            Children = new List<Node<T>>() { nodeA, nodeB };
        }

        public Selector(string name, Func<T, bool> condition, Node<T> nodeA, Node<T> nodeB) : base(name)
        {
            Condition = condition;
            Children = new List<Node<T>>() { nodeA, nodeB };
        }

        public Func<T, bool> Condition { get; set; }

        public override BehaviorTreeStatus Execute(T blackboard)
        {
            return GetNodeToExecute(blackboard).Execute(blackboard);
        }

        internal override Node<T> GetNodeToExecute(T blackboard)
        {
            if (Condition(blackboard))
            {
                return Children[0];
            }
            else
            {
                return Children[1];
            }
        }
    }
}