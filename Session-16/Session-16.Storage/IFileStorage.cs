namespace Session_16.Storage {
    public interface IFileStorage<T> {
        public T Load();
        public void Save(T obj);
    }
}