namespace SimpleFactroy
{
    public interface IBeverageProvide
    {
        // 加料
        void AddMaterial();
        // 沖泡
        void Brew();
        // 裝杯
        void PouredCup();
    }
}
