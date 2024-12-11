namespace MaterialPlanningService.Models.FrameHouse
{
    /// <summary>
    /// модель для представления каркасного дома
    /// </summary>
    public class FrameRequest
    {
        /// <summary>
        /// Длина стен в метрах.
        /// </summary>
        public double WallLength { get; set; }

        /// <summary>
        /// Высота стен в метрах.
        /// </summary>
        public double WallHeight { get; set; }

        /// <summary>
        /// Шаг стоек в метрах.
        /// </summary>
        public double PostSpacing { get; set; }

        /// <summary>
        /// Шаг распорок в метрах.
        /// </summary>
        public double BraceSpacing { get; set; }
    }
}
