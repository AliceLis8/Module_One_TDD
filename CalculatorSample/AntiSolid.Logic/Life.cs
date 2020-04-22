namespace AntiSolid.Logic
{
    public class Life
    {
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }
            return this.ToString().Equals(obj.ToString(), System.StringComparison.OrdinalIgnoreCase);
        }
        public virtual string PrintEmotion()
        {
            return "+";
        }
    }
}