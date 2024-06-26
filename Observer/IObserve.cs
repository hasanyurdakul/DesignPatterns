namespace Observer
{
    public interface IObserve
    {
        public void Update();
        public void SetSubject(ISubject subject);
    }
}