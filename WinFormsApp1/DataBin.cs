namespace howto_histogram
{
    public class DataBin
    {
        public float BeginBound;
        public float EndBound;
        public float Value;

        public DataBin(float beginBound, float width)
        {
            BeginBound = beginBound;
            EndBound = beginBound + width;
        }

        public void Add(float _value)
        {
            if (_value >= BeginBound && _value < EndBound)
            {
                Value++;
            }
        }
        
    }
    
}