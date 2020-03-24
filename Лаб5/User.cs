
namespace Лаб5
{
    /// <summary>
    /// Абстрактный класс User с методами будущих сервисов
    /// </summary>
    public abstract class User
    {
        public string Name { get; set; }
        public abstract void GetMusic();
        public abstract void GetVideo();
        public abstract void AddMusic();
        public abstract void AddVideo();
    }
}
