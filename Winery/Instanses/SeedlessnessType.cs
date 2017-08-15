namespace Winery.Instanses
{
    public sealed class SeedlessnessType
    {
        #region PROPERTIES
        public int Id
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTOR
        public SeedlessnessType(int id, string type)
        {
            Id = id;
            Type = type;
        }
        #endregion
    }
}
