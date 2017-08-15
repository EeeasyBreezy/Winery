namespace Winery.Instanses
{
    public sealed class OriginCountry
    {
        #region PROPERTIES
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        public OriginCountry(int id, string name)
        {
            Id = id; Name = name;
        }
        #endregion
    }
}
