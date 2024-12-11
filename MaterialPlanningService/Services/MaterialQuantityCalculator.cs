using MaterialPlanningService.Impl;
using MaterialPlanningService.Models.BrickHouse;
using MaterialPlanningService.Models.FrameHouse;
using MaterialPlanningService.Models.WallBlocks;

namespace MaterialPlanningService.Services
{
    public class MaterialQuantityCalculator : IMaterialQuantity
    {
        /// <summary>
        /// посчитать количество кирпичей
        /// </summary>
        /// <param name="brick"></param>
        /// <returns></returns>
        public double CalculateBrickQuantity(BrickRequest brick)
        {
            var value = BrickTableServices.GetCurrentBrickValue(brick);
            return brick.CoverageArea * value;
        }
        /// <summary>
        /// посчитать материалы для каркасного дома
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public FrameHouseMaterialResult CalculateFrameHouseMaterials(FrameRequest request)
        {
            int totalBoards = (int)Math.Ceiling(request.WallLength / request.PostSpacing) + 1;
            double totalBoardsLength = totalBoards * request.WallHeight;
            int fastenersCount = (int)Math.Ceiling(request.WallLength / request.BraceSpacing) + 1;
            return new FrameHouseMaterialResult(
                boards: totalBoards,
                length: totalBoardsLength,
                fasteners: fastenersCount
            );
        }
        /// <summary>
        /// посчитать материалы для блочного дома
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public WallHouseMaterialResult CalculateWallBlockQuantity(WallRequest request)
        {
            return new WallHouseMaterialResult(request.ContainerVolume,
                request.ContainerVolume * request.GlueConsumptionRate);
        }
    }

   
}
