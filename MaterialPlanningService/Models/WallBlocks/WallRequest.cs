namespace MaterialPlanningService.Models.WallBlocks
{
    /// <summary>
    /// Модель для представления дома, построенного из бетонных блоков.
    /// </summary>
    public class WallRequest
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
        /// Норма расхода клея (кг/м3).
        /// </summary>
        public double GlueConsumptionRate { get; set; }
        /// <summary>
        /// Периметр строения (м).
        /// </summary>
        public double Perimeter => (Length + Width) * 2;
        
        /// <summary>
        /// Толщина стен (м).
        /// </summary>
        public double WallThickness { get; set; }

        /// <summary>
        /// Объем тары (м3).
        /// </summary>
        public double ContainerVolume => Perimeter * WallThickness * Height;

       
    }
}
