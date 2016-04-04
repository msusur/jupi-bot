using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Connector;

namespace MyApp.Bot
{
    [LuisModel("54ccc350-52e3-4bc3-a287-b4ad8b21e5d6", "1f2bb88a84c64f6a9491b6f31842ce59")]
    [Serializable]
    public class SozlukQuery : LuisDialog
    {
        private readonly BuildForm<QueryModel> _form;

        public SozlukQuery(BuildForm<QueryModel> form)
        {
            _form = form;
        }

    }

    public class QueryModel
    {
        public string TitleName { get; set; }
        public bool Popular { get; set; }
    }
}