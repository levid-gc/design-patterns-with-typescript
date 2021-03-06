﻿using ChainOfResponsibility.MethodChain;

using static System.Console;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodChainRun();
        }

        public static void MethodChainRun()
        {
            var goblin = new Creature("Goblin", 1, 1);
            WriteLine(goblin);

            var root = new CreatureModifier(goblin);
            root.Add(new DoubleAttackModifier(goblin));
            root.Add(new DoubleAttackModifier(goblin));
            root.Add(new IncreaseDefenseModifier(goblin));

            root.Handle();
            WriteLine(goblin);
        }
    }
}
