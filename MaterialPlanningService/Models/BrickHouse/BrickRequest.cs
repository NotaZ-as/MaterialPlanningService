namespace MaterialPlanningService.Models.BrickHouse
{
    /// <summary>
    /// Модель для представления дома, построенного из кирпича.
    /// </summary>
    public class BrickRequest
    {
        /// <summary>
        /// Длина дома (в метрах).
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Ширина дома (в метрах).
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Высота дома (в метрах).
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Периметр дома (в метрах).
        /// </summary>
        public double Perimeter => 2 * (Length + Width); 
        
        /// <summary>
        /// Площадь покрытия (периметр * высота).
        /// </summary>
        public double CoverageArea => Perimeter * Height;

        /// <summary>
        /// Размер кирпича (одинарный, полуторный, двойной).
        /// </summary>
        public BrickSize BrickSize { get; set; }

        /// <summary>
        /// Единицы измерения кирпича (полкирпича, один, полтора и т.д.).
        /// </summary>
        public BrickUnit BrickUnit { get; set; }

        /// <summary>
        /// Тип кладки (однослойная, двухслойная, трехслойная).
        /// </summary>
        public BrickLayingType LayingType { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="brickSize"></param>
        /// <param name="brickUnit"></param>
        /// <param name="layingType"></param>
        public BrickRequest(double length, double width, double height, BrickSize brickSize, BrickUnit brickUnit, BrickLayingType layingType)
        {
            Length = length;
            Width = width;
            Height = height;
            BrickSize = brickSize;
            BrickUnit = brickUnit;
            LayingType = layingType;
        }

    }

    /// <summary>
    /// Размер кирпича.
    /// </summary>
    public enum BrickSize
    {
        /// <summary>
        /// Одинарный
        /// </summary>
        Single,       
        /// <summary>
        /// Полуторный
        /// </summary>
        OneAndHalf,  
        /// <summary>
        /// Двойной
        /// </summary>
        Double       
    }

    /// <summary>
    /// Единицы измерения кирпича.
    /// </summary>
    public enum BrickUnit
    {
        /// <summary>
        /// Полкирпича
        /// </summary>
        Half,
        /// <summary>
        /// Один кирпич
        /// </summary>
        One,

        /// <summary>
        /// Полтора кирпича
        /// </summary>
        OneAndHalf,
        /// <summary>
        /// Два кирпича
        /// </summary>
        Two,
        /// <summary>
        /// Два с половиной кирпича
        /// </summary>
        TwoAndHalf
    }

    /// <summary>
    /// Тип кладки кирпича.
    /// </summary>
    public enum BrickLayingType
    {
        /// <summary>
        /// Однослойная кладка
        /// </summary>
        SingleLayer,
        /// <summary>
        /// Двухслойная кладка
        /// </summary>
        DoubleLayer,
        /// <summary>
        /// Трехслойная кладка
        /// </summary>
        TripleLayer
    }
}
