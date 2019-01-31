using System.ComponentModel;

namespace WindowsApplication3
{
    public static class ItemList
    {
        public static BindingList<Item> GetList()
        {
            var list = new BindingList<Item>();
            for (int i = 0; i < 50; i++)
                list.Add(new Item() { Column1 = "Test1" + i, Column2 = "Test2" + i, Column3 = "Test3" + i, Column4 = "Test4" + i, Column5 = "Test5" + i, Column6 = "Test6" + i, Column7 = "Test7" + i, Column8 = "Test8" + i, Column9 = "Test9" + i, Column10 = "Test10" + i, Column11 = "Test11" + i, Column12 = "Test12" + i, Column13 = "Test13" + i, Column14 = "Test14" + i, Column15 = "Test15" + i, Column16 = "Test16" + i });
            return list;
        }
    }
    public class Item
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }
        public string Column8 { get; set; }
        public string Column9 { get; set; }
        public string Column10 { get; set; }
        public string Column11 { get; set; }
        public string Column12 { get; set; }
        public string Column13 { get; set; }
        public string Column14 { get; set; }
        public string Column15 { get; set; }
        public string Column16 { get; set; }
    }
}
