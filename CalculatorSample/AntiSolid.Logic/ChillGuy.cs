namespace AntiSolid.Logic
{
    public class ChillGuy
    {
        public bool HasEmotion => Emotion != null;
        public Life Emotion { get; set; }

        public void RecieveBigBag()
        {
            Emotion = new Life();
        }

        public void AddSmart()
        {
            Emotion = new Power();
        }
    }
}