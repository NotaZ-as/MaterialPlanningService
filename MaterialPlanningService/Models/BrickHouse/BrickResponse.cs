using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MaterialPlanningService.Models.BrickHouse
{
    /// <summary>
    /// Модель для ответа кирпичного дома
    /// </summary>
    public class BrickResponse
    {
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
        /// Количество кирпичей
        /// </summary>
        public double TotalBrickCount { get; set; }

    }
}
