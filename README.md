
**MaterialPlanningService** — это сервис, предоставляющий API для расчета необходимого количества материалов для различных типов домов.
## Контроллеры

### MaterialQuantityController

Контроллер, отвечающий за операции, связанные с расчетом количества материалов.

- **Метод:** `GetAvailableMaterials`
    
    - **Описание:** Получить список доступных видов домов.
    - **Ответы:**
        - `200`: Запрос успешный.
- **Метод:** `CalculateBricksHouse`
    
    - **Описание:** Получить количество материала для кирпичного дома.
    - **Параметры:**
        - `brickRequest`: Запрос с параметрами кирпичного дома.
    - **Пример запроса:**
        
        http
        
        Копировать код
        
        `POST /api/MaterialQuantityController/BrickHouse {   "length": 10,   "width": 10,   "height": 10,   "brickSize": 1,   "brickUnit": 2,   "layingType": 2 }`
        
    - **Ответы:**
        - `200`: Запрос успешный.
- **Метод:** `CalculateWall`
    
    - **Описание:** Получить количество материала для стенового дома.
    - **Параметры:**
        - `wallRequest`: Запрос с параметрами стенового дома.
    - **Пример запроса:**
        
        http
        
        Копировать код
        
        `POST /api/MaterialQuantityController/WallHouse {   "length": 10,   "width": 10,   "height": 10,   "glueConsumptionRate": 28,   "wallThickness": 0.25 }`
        
    - **Ответы:**
        - `200`: Запрос успешный.
- **Метод:** `CalculateFrame`
    
    - **Описание:** Получить количество материала для каркасного дома.
    - **Параметры:**
        - `frameRequest`: Запрос с параметрами каркасного дома.
    - **Пример запроса:**
        
        http
        
        Копировать код
        
        `POST /api/MaterialQuantityController/FrameHouse {   "wallLength": 10,   "wallHeight": 7,   "postSpacing": 0.25,   "braceSpacing": 0.25 }`
        
    - **Ответы:**
        - `200`: Запрос успешный.

## Модели

### BrickRequest
Модель для представления дома, построенного из кирпича.
- `Length`: Длина дома (в метрах).
- `Width`: Ширина дома (в метрах).
- `Height`: Высота дома (в метрах).
- `BrickSize`: Размер кирпича (одинарный, полуторный, двойной).
- `BrickUnit`: Единицы измерения кирпича (полкирпича, один, полтора и т.д.).
- `LayingType`: Тип кладки (однослойная, двухслойная, трехслойная).

### BrickResponse
Модель ответа для кирпичного дома.
- `BrickSize`: Размер кирпича.
- `BrickUnit`: Единицы измерения кирпича.
- `LayingType`: Тип кладки.
- `TotalBrickCount`: Общее количество кирпичей.

### FrameRequest
Модель для представления каркасного дома.
- `WallLength`: Длина стен (в метрах).
- `WallHeight`: Высота стен (в метрах).
- `PostSpacing`: Шаг стоек (в метрах).
- `BraceSpacing`: Шаг распорок (в метрах).
### FrameResponse
Модель ответа для каркасного дома.
- `TotalBoards`: Количество стоек (шт.).
- `LengthBoards`: Длина стоек (м).
- `Fasteners`: Количество крепежных элементов (шт.).

### WallRequest
Модель для представления дома, построенного из бетонных блоков.**
- `Length`: Длина дома (в метрах).
- `Width`: Ширина дома (в метрах).
- `Height`: Высота дома (в метрах).
- `GlueConsumptionRate`: Норма расхода клея (кг/м³).
- `WallThickness`: Толщина стен (в метрах).

### WallResponse
Модель ответа для дома из бетонных блоков.
- `TotalBlocks`: Общее количество блоков.
- `TotalGlue`: Общее количество клея (кг).
