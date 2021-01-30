using System.Collections.Generic;

namespace PasswordGenerator
{

    static class PasswordWordListConstants
    {
        public const int AlphabetType = 0;
        public const int NumberType = 1;
        public const int SymbolType = 2;

        public const string AlphabetWords = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string NumberWords = "0123456789";
        public const string SymbolWords = "#$%&-=_";
    }

    class PasswordWordList
    {

        private string[] __wordType;
        private string __wordList;

        public PasswordWordList()
        {
            __wordType = new string[3];
            __wordType[PasswordWordListConstants.NumberType] = PasswordWordListConstants.NumberWords;
            __wordType[PasswordWordListConstants.AlphabetType] = PasswordWordListConstants.AlphabetWords;
            __wordType[PasswordWordListConstants.SymbolType] = PasswordWordListConstants.SymbolWords;
        }


        public void SetWordList(List<int> useWordTypes)
        {
            var sb = new System.Text.StringBuilder();

            useWordTypes.ForEach((useWordType) =>
            {
                sb.AppendLine(__wordType[useWordType]);
            });


            this.__wordList = sb.ToString();
        }

        public string GetWordList()
        {
            return this.__wordList;
        }



    }
}
