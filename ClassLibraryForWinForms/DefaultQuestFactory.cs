using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public class DefaultQuestFactory : QuestFactory
    {
        public override Quest CreateQuest()
        {
            return new Quest();
        }
    }
}
