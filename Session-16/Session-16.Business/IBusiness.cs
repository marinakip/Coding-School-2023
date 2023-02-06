namespace Session_16.Business {
    public interface IBusiness {        
        public void LoadRepositories();
        public void AddToRepository<T>(Object obj);    
        public void UpdateRepository<T>(Object obj);    
        public void DeleteFromRepository<T>();    
        public T CreateRepositoryObject<T>();           

    }
}