namespace Winery.Instanses
{
    public sealed class WineSortCategory
    {
        #region PROPERTIES
        public int Id
        {
            get; set;
        }
        public string Sort
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        public WineSortCategory(int id, string sort)
        {
            Id = id;
            Sort = sort;
        }
        #endregion
    }
}