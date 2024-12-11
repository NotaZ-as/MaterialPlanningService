using MaterialPlanningService.Models.BrickHouse;

namespace MaterialPlanningService.Services
{
    public class BrickTableServices
    {
      
        /// <summary>
        /// получить табличное значение
        /// </summary>
        /// <param name="size"></param>
        /// <param name="layingType"></param>
        /// <param name="brickUnit"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private static int GetValueByBrickParameters(BrickSize size, BrickLayingType layingType, BrickUnit brickUnit)
        {
            switch (brickUnit)
            {
                case BrickUnit.Half:
                    switch (layingType)
                    {
                        case BrickLayingType.SingleLayer:
                            return 12;
                           
                        case BrickLayingType.DoubleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 61;
                                case BrickSize.OneAndHalf:
                                    return 45;
                                case BrickSize.Double:
                                    return 30;
                                default:
                                    return (61 + 45 + 40) / 3;
                            }
                        case BrickLayingType.TripleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 51;
                                case BrickSize.OneAndHalf:
                                    return 39;
                                case BrickSize.Double:
                                    return 26;
                                default:
                                    return (51 + 39 + 26) / 3;
                            }
                        default:
                            throw new ArgumentOutOfRangeException(nameof(layingType), "Неподдерживаемый вид кладки.");
                    }
                case BrickUnit.One:
                    switch (layingType)
                    {
                        case BrickLayingType.SingleLayer:
                            return 25;
                           
                        case BrickLayingType.DoubleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 128;
                                case BrickSize.OneAndHalf:
                                    return 95;
                                case BrickSize.Double:
                                    return 60;
                                default:
                                    return (128 + 95 + 60) / 3;
                            }
                        case BrickLayingType.TripleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 102;
                                case BrickSize.OneAndHalf:
                                    return 78;
                                case BrickSize.Double:
                                    return 52;
                                default:
                                    return (102 + 78 + 52) / 3;
                            }
                        default:
                            throw new ArgumentOutOfRangeException(nameof(layingType), "Неподдерживаемый вид кладки.");
                    }
                case BrickUnit.OneAndHalf:
                    switch (layingType)
                    {
                        case BrickLayingType.SingleLayer:
                            return 38;
                          
                        case BrickLayingType.DoubleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 189;
                                case BrickSize.OneAndHalf:
                                    return 140;
                                case BrickSize.Double:
                                    return 90;
                                default:
                                    return (189 + 140 + 90) / 3;
                            }
                        case BrickLayingType.TripleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 153;
                                case BrickSize.OneAndHalf:
                                    return 117;
                                case BrickSize.Double:
                                    return 78;
                                default:
                                    return (153 + 117 + 78) / 3;
                            }
                        default:
                            throw new ArgumentOutOfRangeException(nameof(layingType), "Неподдерживаемый вид кладки.");
                    }
                case BrickUnit.Two:
                    switch (layingType)
                    {
                        case BrickLayingType.SingleLayer:
                            return 51;

                        case BrickLayingType.DoubleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 256;
                                case BrickSize.OneAndHalf:
                                    return 190;
                                case BrickSize.Double:
                                    return 120;
                                default:
                                    return (256 + 190 + 120) / 3;
                            }
                        case BrickLayingType.TripleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 204;
                                case BrickSize.OneAndHalf:
                                    return 156;
                                case BrickSize.Double:
                                    return 104;
                                default:
                                    return (204 + 156 + 104) / 3;
                            }
                        default:
                            throw new ArgumentOutOfRangeException(nameof(layingType), "Неподдерживаемый вид кладки.");
                    }
                case BrickUnit.TwoAndHalf:
                    switch (layingType)
                    {
                        case BrickLayingType.SingleLayer:
                            return 64;
                        case BrickLayingType.DoubleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 317;
                                case BrickSize.OneAndHalf:
                                    return 235;
                                case BrickSize.Double:
                                    return 150;
                                default:
                                    return (317 + 235 + 150) / 3;
                            }
                        case BrickLayingType.TripleLayer:
                            switch (size)
                            {
                                case BrickSize.Single:
                                    return 255;
                                case BrickSize.OneAndHalf:
                                    return 195;
                                case BrickSize.Double:
                                    return 130;
                                default:
                                    return (255 + 195 + 130) / 3;
                            }
                        default:
                            throw new ArgumentOutOfRangeException(nameof(layingType), "Неподдерживаемый вид кладки.");
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(size), "Неподдерживаемый размер кирпича.");
            }
        }


        /// <summary>
        /// получить конечное значение
        /// </summary>
        /// <param name="house"></param>
        /// <returns></returns>
        public static double GetCurrentBrickValue(BrickRequest house)
        {
            var value = GetValueByBrickParameters(house.BrickSize, house.LayingType, house.BrickUnit);
            switch (house.BrickUnit)
            {
                case BrickUnit.Half:
                    return value * 2;
                case BrickUnit.OneAndHalf:
                    return value * 3;
                case BrickUnit.Two:
                    return value * 4;
                default:
                    return value;
            }
        }


    }
}
