namespace Session_16.Storage {
    public interface IStorage<T> {
        public T Load();
        public void Save(T obj);
    }
}