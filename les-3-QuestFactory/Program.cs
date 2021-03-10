using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    //brons QuestFactory
    class Program
    {
        static void Main(string[] args)
        {
           Quest q = QuestFactory.CreateQuest(QuestType.WarriorTavern);
           Console.WriteLine($"{q.Description}");
           Console.ReadKey();
        }

        public enum QuestType
        {
            GoblinDungeon,
            WarriorTavern,
            Garden
        }

        public static class QuestFactory
        {
            public static Quest CreateQuest(QuestType questType)
            {
                switch (questType)
                {
                    case QuestType.GoblinDungeon:
                        return new Quest("Goblin Dungeon", "A dungeon full of goblins.. Please help us traveler!");
                    case QuestType.WarriorTavern:
                        return new Quest("Warrior's Tarvern", "A warrior who owns a tarvern has reached out to you. Visit him.");
                    case QuestType.Garden:
                        return new Quest("Rose Garden", "The roses are wonderful.. but smelling them will change your fate..");
                    default:
                        Console.WriteLine("No Quest found for type " + questType);
                        return null;
                }
            }
        }
        public class Quest
        {
            public string Title
            {
                get; private set;
            }

            public string Description
            {
                get; private set;
            }

            public Quest(string title, string description)
            {
                Title = title;
                Description = description;
            }
        }
    }
}
