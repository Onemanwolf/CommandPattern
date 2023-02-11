namespace CommandPattern
{


        public interface IRepo<T>
        {
            void Save(T order);
        }
    
}