namespace Blockbuster___MultiFileProject
{
    public class VHSTape
    {
        public string Name { set; get; }
        public bool Rented { set; get; }
        public float Progress { set; get; }
        public float Duration { set; get; }

        public VHSTape(string name, float length)
        {
            Name = name;
            Duration = length;
            Rented = false;
            Progress = 0.0f;
        }
        public void Play(float duration)
        {
            Progress += duration;
            if (Progress > Duration)
            {
                Progress = Duration;
            }
        }
        public void Rewind(float duration)
        {
            Progress -= duration;
            if (Progress < 0)
            {
                Progress = 0;
            }
        }
        public bool IsRented()
        {
            return Rented;
        }
    }
}
