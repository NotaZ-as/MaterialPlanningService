using System;
using System.ComponentModel;
using MaterialPlanningService.Models.BrickHouse;
using MaterialPlanningService.Models.FrameHouse;
using MaterialPlanningService.Models.WallBlocks;

namespace MaterialPlanningService.Impl
{
    public interface IMaterialQuantity
    {
        /// <summary>
        /// Рассчитывает количество материалов для каркасного дома.
        /// </summary>
        /// <returns>Структура с деталями расчета.</returns>
        FrameHouseMaterialResult CalculateFrameHouseMaterials(FrameRequest request);

        /// <summary>
        /// Рассчитывает количество кирпича.
        /// </summary>
        /// <param name="request">Площадь стен (кв. м).</param>
        /// <returns>Количество кирпича.</returns>
        double CalculateBrickQuantity(BrickRequest request);

        /// <summary>
        /// Рассчитывает количество стеновых блоков.
        /// </summary>
        /// <param name="request">Площадь стен (кв. м).</param>
        /// <returns>Количество стеновых блоков.</returns>
        WallHouseMaterialResult CalculateWallBlockQuantity(WallRequest request);
    }

   
   


    public enum BuildingMaterial
    {
        [Description("Каркасный дом")]
        FrameHouse,

        [Description("Кирпич")]
        BrickHouse,

        [Description("Стеновые блоки")]
        WallHouse
    }
}