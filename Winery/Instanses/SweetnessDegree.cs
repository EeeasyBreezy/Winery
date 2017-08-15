namespace Winery.Instanses
{
    public sealed class SweetnessDegree
    {
        #region PROPERTIES
        public int Id
        {
            get; set;
        }
        public string Degree
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        public SweetnessDegree(int id, string degree)
        {
            Id = id;
            Degree = degree;
        }
        #endregion
    }
}