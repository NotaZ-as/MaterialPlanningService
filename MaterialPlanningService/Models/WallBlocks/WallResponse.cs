using MaterialPlanningService.Impl;

namespace MaterialPlanningService.Models.WallBlocks
{
    /// <summary>
    /// Модель для ответа бетонного дома
    /// </summary>
    public class WallResponse
    {
        public double TotalBricks { get; set; }
        public double TotalGlue { get; set; }

    }
    /// <summary>
    /// Результат расчета материалов для блочного дома.
    /// </summary>
    public struct WallHouseMaterialResult
    {
        public double TotalBricks { get; set; }
        public double TotalGlue { get; set; }

        public WallHouseMaterialResult(double bricks, double glue)
        {
            TotalBricks = bricks;
            TotalGlue = glue;
        }
    }
}
