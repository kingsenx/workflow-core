﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkflowCore.Interface;

namespace WorkflowCore.TestAssets.Workflows.HelloWorld
{
    public class HelloWorldWorkflow : IWorkflow
    {
        public void Build(IWorkflowBuilder<object> builder)
        {
            builder
                .StartWith<HelloWorld>()
                .Then<GoodbyeWorld>();
        }

        public string Id
        {
            get
            {
                return "HelloWorld";
            }
        }

        public int Version
        {
            get
            {
                return 1;
            }
        }
    }
}
