using MaterialPlanningService.Impl;

namespace MaterialPlanningService.Models.FrameHouse
{
    /// <summary>
    /// Модель для ответа каркасного дома
    /// </summary>
    public class FrameResponse
    {
        /// <summary>
        /// Количество стоек (шт.).
        /// </summary>
        public int TotalBoards { get; set; }

        /// <summary>
        /// Длина стоек ( м).
        /// </summary>
        public double LengthBoards { get; set; }

        /// <summary>
        /// Количество крепежных элементов (шт.).
        /// </summary>
        public int Fasteners { get; set; }
    }

    /// <summary>
    /// Результат расчета материалов для каркасного дома.
    /// </summary>
    public struct FrameHouseMaterialResult
    {
        /// <summary>
        /// Количество стоек (шт.).
        /// </summary>
        public int TotalBoards { get; set; }

        /// <summary>
        /// Длина стоек ( м).
        /// </summary>
        public double LengthBoards { get; set; }

        /// <summary>
        /// Количество крепежных элементов (шт.).
        /// </summary>
        public int Fasteners { get; set; }

        public FrameHouseMaterialResult(int boards, double length, int fasteners)
        {
            TotalBoards = boards;
            LengthBoards = length;
            Fasteners = fasteners;
        }
    }
}
