namespace TESVSnip.Domain.Model
{
    public abstract class BatchCriteria
    {
        public bool Checked { get; set; }

        public string Name { get; set; }

        public abstract bool Evaluate(Record r);

        public abstract bool Evaluate(Record r, SubRecord sr);
    }
}