using System;
using System.Collections.Generic;
using MySQL.Entities;

namespace Library.Services
{
    class EnumToDictionary
    {
        public static Dictionary<string, int> BookType()
        {
            Dictionary<string, int> dictionary = new Dictionary<string,int>();

            foreach (int enumValue in Enum.GetValues(typeof(BookType)))
            {
                dictionary.Add(Enum.GetName(typeof(BookType),enumValue) ,enumValue);
            }

            return dictionary;
        }
    }
}
