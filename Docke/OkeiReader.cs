﻿using DockeLib.Data;
using Newtonsoft.Json;

namespace DockeLib
{
    public class OkeiReader
    {
        public static List<OkeiEntry> ReadOkeiEntries()
        {
            try
            {
                var okeiEntries = JsonConvert.DeserializeObject<List<OkeiEntry>>(OkeiJson.Values) ?? [];
                return okeiEntries;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading OKEI JSON file: {ex.Message}");
            }
        }
    }

    public static class OkeiJson
    {
        public const string Values =
            """
                        [
                {
                    "code": "354",
                    "name": "Секунда",
                    "shortName": "с",
                    "codeName": "С"
                },
                {
                    "code": "355",
                    "name": "Минута",
                    "shortName": "мин",
                    "codeName": "МИН"
                },
                {
                    "code": "356",
                    "name": "Час",
                    "shortName": "ч",
                    "codeName": "Ч"
                },
                {
                    "code": "359",
                    "name": "Сутки",
                    "shortName": "сут; дн",
                    "codeName": "СУТ; ДН"
                },
                {
                    "code": "360",
                    "name": "Неделя",
                    "shortName": "нед",
                    "codeName": "НЕД"
                },
                {
                    "code": "361",
                    "name": "Декада",
                    "shortName": "дек",
                    "codeName": "ДЕК"
                },
                {
                    "code": "362",
                    "name": "Месяц",
                    "shortName": "мес",
                    "codeName": "МЕС"
                },
                {
                    "code": "364",
                    "name": "Квартал",
                    "shortName": "кварт",
                    "codeName": "КВАРТ"
                },
                {
                    "code": "365",
                    "name": "Полугодие",
                    "shortName": "полгода",
                    "codeName": "ПОЛГОД"
                },
                {
                    "code": "366",
                    "name": "Год",
                    "shortName": "г; лет",
                    "codeName": "ГОД; ЛЕТ"
                },
                {
                    "code": "368",
                    "name": "Десятилетие",
                    "shortName": "деслет",
                    "codeName": "ДЕСЛЕТ"
                },
                {
                    "code": "003",
                    "name": "Миллиметр",
                    "shortName": "мм",
                    "codeName": "ММ"
                },
                {
                    "code": "004",
                    "name": "Сантиметр",
                    "shortName": "см",
                    "codeName": "СМ"
                },
                {
                    "code": "005",
                    "name": "Дециметр",
                    "shortName": "дм",
                    "codeName": "ДМ"
                },
                {
                    "code": "006",
                    "name": "Метр",
                    "shortName": "м",
                    "codeName": "М"
                },
                {
                    "code": "008",
                    "name": "Километр; тысяча метров",
                    "shortName": "км; 103 м",
                    "codeName": "КМ; ТЫС М"
                },
                {
                    "code": "009",
                    "name": "Мегаметр; миллион метров",
                    "shortName": "Мм; 106 м",
                    "codeName": "МЕГАМ; МЛН М"
                },
                {
                    "code": "039",
                    "name": "Дюйм (25,4 мм)",
                    "shortName": "дюйм",
                    "codeName": "ДЮЙМ"
                },
                {
                    "code": "041",
                    "name": "Фут (0,3048 м)",
                    "shortName": "фут",
                    "codeName": "ФУТ"
                },
                {
                    "code": "043",
                    "name": "Ярд (0,9144 м)",
                    "shortName": "ярд",
                    "codeName": "ЯРД"
                },
                {
                    "code": "047",
                    "name": "Морская миля (1852 м)",
                    "shortName": "миля",
                    "codeName": "МИЛЬ"
                },
                {
                    "code": "160",
                    "name": "Гектограмм",
                    "shortName": "гг",
                    "codeName": "ГГ"
                },
                {
                    "code": "161",
                    "name": "Миллиграмм",
                    "shortName": "мг",
                    "codeName": "МГ"
                },
                {
                    "code": "162",
                    "name": "Метрический карат",
                    "shortName": "кар",
                    "codeName": "КАР"
                },
                {
                    "code": "163",
                    "name": "Грамм",
                    "shortName": "г",
                    "codeName": "Г"
                },
                {
                    "code": "164",
                    "name": "Микрограмм",
                    "shortName": "мкг",
                    "codeName": "МКГ"
                },
                {
                    "code": "166",
                    "name": "Килограмм",
                    "shortName": "кг",
                    "codeName": "КГ"
                },
                {
                    "code": "168",
                    "name": "Тонна; метрическая тонна (1000 кг)",
                    "shortName": "т",
                    "codeName": "Т"
                },
                {
                    "code": "170",
                    "name": "Килотонна",
                    "shortName": "103 т",
                    "codeName": "КТ"
                },
                {
                    "code": "173",
                    "name": "Сантиграмм",
                    "shortName": "сг",
                    "codeName": "СГ"
                },
                {
                    "code": "181",
                    "name": "Брутто-регистровая тонна (2,8316 м3)",
                    "shortName": "БРТ",
                    "codeName": "БРУТТ. РЕГИСТР Т"
                },
                {
                    "code": "185",
                    "name": "Грузоподъемность в метрических тоннах",
                    "shortName": "т грп",
                    "codeName": "Т ГРУЗОПОД"
                },
                {
                    "code": "206",
                    "name": "Центнер (метрический) (100 кг); гектокилограмм; квинтал1 (метрический); децитонна",
                    "shortName": "ц",
                    "codeName": "Ц"
                },
                {
                    "code": "110",
                    "name": "Кубический миллиметр",
                    "shortName": "мм3",
                    "codeName": "ММ3"
                },
                {
                    "code": "111",
                    "name": "Кубический сантиметр; миллилитр",
                    "shortName": "см3; мл",
                    "codeName": "СМ3; МЛ"
                },
                {
                    "code": "112",
                    "name": "Литр; кубический дециметр",
                    "shortName": "л; дм3",
                    "codeName": "Л; ДМ3"
                },
                {
                    "code": "113",
                    "name": "Кубический метр",
                    "shortName": "м3",
                    "codeName": "М3"
                },
                {
                    "code": "118",
                    "name": "Децилитр",
                    "shortName": "дл",
                    "codeName": "ДЛ"
                },
                {
                    "code": "122",
                    "name": "Гектолитр",
                    "shortName": "гл",
                    "codeName": "ГЛ"
                },
                {
                    "code": "126",
                    "name": "Мегалитр",
                    "shortName": "Мл",
                    "codeName": "МЕГАЛ"
                },
                {
                    "code": "131",
                    "name": "Кубический дюйм (16387,1 мм3)",
                    "shortName": "дюйм3",
                    "codeName": "ДЮЙМ3"
                },
                {
                    "code": "132",
                    "name": "Кубический фут (0,02831685 м3)",
                    "shortName": "фут3",
                    "codeName": "ФУТ3"
                },
                {
                    "code": "133",
                    "name": "Кубический ярд (0,764555 м3)",
                    "shortName": "ярд3",
                    "codeName": "ЯРД3"
                },
                {
                    "code": "159",
                    "name": "Миллион кубических метров",
                    "shortName": "106 м3",
                    "codeName": "МЛН М3"
                },
                {
                    "code": "050",
                    "name": "Квадратный миллиметр",
                    "shortName": "мм2",
                    "codeName": "ММ2"
                },
                {
                    "code": "051",
                    "name": "Квадратный сантиметр",
                    "shortName": "см2",
                    "codeName": "СМ2"
                },
                {
                    "code": "053",
                    "name": "Квадратный дециметр",
                    "shortName": "дм2",
                    "codeName": "ДМ2"
                },
                {
                    "code": "055",
                    "name": "Квадратный метр",
                    "shortName": "м2",
                    "codeName": "М2"
                },
                {
                    "code": "058",
                    "name": "Тысяча квадратных метров",
                    "shortName": "103 м2",
                    "codeName": "ТЫС М2"
                },
                {
                    "code": "059",
                    "name": "Гектар",
                    "shortName": "га",
                    "codeName": "ГА"
                },
                {
                    "code": "061",
                    "name": "Квадратный километр",
                    "shortName": "км2",
                    "codeName": "КМ2"
                },
                {
                    "code": "071",
                    "name": "Квадратный дюйм (645,16 мм2)",
                    "shortName": "дюйм2",
                    "codeName": "ДЮЙМ2"
                },
                {
                    "code": "073",
                    "name": "Квадратный фут (0,092903 м2)",
                    "shortName": "фут2",
                    "codeName": "ФУТ2"
                },
                {
                    "code": "075",
                    "name": "Квадратный ярд (0,8361274 м2)",
                    "shortName": "ярд2",
                    "codeName": "ЯРД2"
                },
                {
                    "code": "109",
                    "name": "Ар (100 м2)",
                    "shortName": "а",
                    "codeName": "АР"
                },
                {
                    "code": "212",
                    "name": "Ватт",
                    "shortName": "Вт",
                    "codeName": "ВТ"
                },
                {
                    "code": "214",
                    "name": "Киловатт",
                    "shortName": "кВт",
                    "codeName": "КВТ"
                },
                {
                    "code": "215",
                    "name": "Мегаватт; тысяча киловатт",
                    "shortName": "МВт; 103 кВт",
                    "codeName": "МЕГАВТ; ТЫС КВТ"
                },
                {
                    "code": "222",
                    "name": "Вольт",
                    "shortName": "В",
                    "codeName": "В"
                },
                {
                    "code": "223",
                    "name": "Киловольт",
                    "shortName": "кВ",
                    "codeName": "КВ"
                },
                {
                    "code": "227",
                    "name": "Киловольт-ампер",
                    "shortName": "кВ.А",
                    "codeName": "КВ.А"
                },
                {
                    "code": "228",
                    "name": "Мегавольт-ампер (тысяча киловольт-ампер)",
                    "shortName": "МВ.А",
                    "codeName": "МЕГАВ.А"
                },
                {
                    "code": "230",
                    "name": "Киловар",
                    "shortName": "квар",
                    "codeName": "КВАР"
                },
                {
                    "code": "243",
                    "name": "Ватт-час",
                    "shortName": "Вт.ч",
                    "codeName": "ВТ.Ч"
                },
                {
                    "code": "245",
                    "name": "Киловатт-час",
                    "shortName": "кВт.ч",
                    "codeName": "КВТ.Ч"
                },
                {
                    "code": "246",
                    "name": "Мегаватт-час; 1000 киловатт-часов",
                    "shortName": "МВт.ч; 103 кВт.ч",
                    "codeName": "МЕГАВТ.Ч; ТЫС КВТ.Ч"
                },
                {
                    "code": "247",
                    "name": "Гигаватт-час (миллион киловатт-часов)",
                    "shortName": "ГВт.ч",
                    "codeName": "ГИГАВТ.Ч"
                },
                {
                    "code": "260",
                    "name": "Ампер",
                    "shortName": "А",
                    "codeName": "А"
                },
                {
                    "code": "263",
                    "name": "Ампер-час (3,6 кКл)",
                    "shortName": "А.ч",
                    "codeName": "А.Ч"
                },
                {
                    "code": "264",
                    "name": "Тысяча ампер-часов",
                    "shortName": "103 А.ч",
                    "codeName": "ТЫС А.Ч"
                },
                {
                    "code": "270",
                    "name": "Кулон",
                    "shortName": "Кл",
                    "codeName": "КЛ"
                },
                {
                    "code": "271",
                    "name": "Джоуль",
                    "shortName": "Дж",
                    "codeName": "ДЖ"
                },
                {
                    "code": "273",
                    "name": "Килоджоуль",
                    "shortName": "кДж",
                    "codeName": "КДЖ"
                },
                {
                    "code": "274",
                    "name": "Ом",
                    "shortName": "Ом",
                    "codeName": "ОМ"
                },
                {
                    "code": "280",
                    "name": "Градус Цельсия",
                    "shortName": "град. C",
                    "codeName": "ГРАД ЦЕЛЬС"
                },
                {
                    "code": "281",
                    "name": "Градус Фаренгейта",
                    "shortName": "град. F",
                    "codeName": "ГРАД ФАРЕНГ"
                },
                {
                    "code": "282",
                    "name": "Кандела",
                    "shortName": "кд",
                    "codeName": "КД"
                },
                {
                    "code": "283",
                    "name": "Люкс",
                    "shortName": "лк",
                    "codeName": "ЛК"
                },
                {
                    "code": "284",
                    "name": "Люмен",
                    "shortName": "лм",
                    "codeName": "ЛМ"
                },
                {
                    "code": "288",
                    "name": "Кельвин",
                    "shortName": "K",
                    "codeName": "К"
                },
                {
                    "code": "289",
                    "name": "Ньютон",
                    "shortName": "Н",
                    "codeName": "Н"
                },
                {
                    "code": "290",
                    "name": "Герц",
                    "shortName": "Гц",
                    "codeName": "ГЦ"
                },
                {
                    "code": "291",
                    "name": "Килогерц",
                    "shortName": "кГц",
                    "codeName": "КГЦ"
                },
                {
                    "code": "292",
                    "name": "Мегагерц",
                    "shortName": "МГц",
                    "codeName": "МЕГАГЦ"
                },
                {
                    "code": "294",
                    "name": "Паскаль",
                    "shortName": "Па",
                    "codeName": "ПА"
                },
                {
                    "code": "296",
                    "name": "Сименс",
                    "shortName": "См",
                    "codeName": "СИ"
                },
                {
                    "code": "297",
                    "name": "Килопаскаль",
                    "shortName": "кПа",
                    "codeName": "КПА"
                },
                {
                    "code": "298",
                    "name": "Мегапаскаль",
                    "shortName": "МПа",
                    "codeName": "МЕГАПА"
                },
                {
                    "code": "300",
                    "name": "Физическая атмосфера (101325 Па)",
                    "shortName": "атм",
                    "codeName": "АТМ"
                },
                {
                    "code": "301",
                    "name": "Техническая атмосфера (98066,5 Па)",
                    "shortName": "ат",
                    "codeName": "АТТ"
                },
                {
                    "code": "302",
                    "name": "Гигабеккерель",
                    "shortName": "ГБк",
                    "codeName": "ГИГАБК"
                },
                {
                    "code": "303",
                    "name": "Килобеккерель",
                    "shortName": "кБк",
                    "codeName": "КИЛОБК"
                },
                {
                    "code": "304",
                    "name": "Милликюри",
                    "shortName": "мКи",
                    "codeName": "МКИ"
                },
                {
                    "code": "305",
                    "name": "Кюри",
                    "shortName": "Ки",
                    "codeName": "КИ"
                },
                {
                    "code": "306",
                    "name": "Грамм делящихся изотопов",
                    "shortName": "г Д/И",
                    "codeName": "Г ДЕЛЯЩ ИЗОТОП"
                },
                {
                    "code": "307",
                    "name": "Мегабеккерель",
                    "shortName": "МБк",
                    "codeName": "МЕГАБК"
                },
                {
                    "code": "308",
                    "name": "Миллибар",
                    "shortName": "мб",
                    "codeName": "МБАР"
                },
                {
                    "code": "309",
                    "name": "Бар",
                    "shortName": "бар",
                    "codeName": "БАР"
                },
                {
                    "code": "310",
                    "name": "Гектобар",
                    "shortName": "гб",
                    "codeName": "ГБАР"
                },
                {
                    "code": "312",
                    "name": "Килобар",
                    "shortName": "кб",
                    "codeName": "КБАР"
                },
                {
                    "code": "314",
                    "name": "Фарад",
                    "shortName": "Ф",
                    "codeName": "Ф"
                },
                {
                    "code": "316",
                    "name": "Килограмм на кубический метр",
                    "shortName": "кг/м3",
                    "codeName": "КГ/М3"
                },
                {
                    "code": "320",
                    "name": "Моль",
                    "shortName": "моль",
                    "codeName": "МОЛЬ"
                },
                {
                    "code": "323",
                    "name": "Беккерель",
                    "shortName": "Бк",
                    "codeName": "БК"
                },
                {
                    "code": "324",
                    "name": "Вебер",
                    "shortName": "Вб",
                    "codeName": "ВБ"
                },
                {
                    "code": "327",
                    "name": "Узел (миля/ч)",
                    "shortName": "уз",
                    "codeName": "УЗ"
                },
                {
                    "code": "328",
                    "name": "Метр в секунду",
                    "shortName": "м/с",
                    "codeName": "М/С"
                },
                {
                    "code": "330",
                    "name": "Оборот в секунду",
                    "shortName": "об/с",
                    "codeName": "ОБ/С"
                },
                {
                    "code": "331",
                    "name": "Оборот в минуту",
                    "shortName": "об/мин",
                    "codeName": "ОБ/МИН"
                },
                {
                    "code": "333",
                    "name": "Километр в час",
                    "shortName": "км/ч",
                    "codeName": "КМ/Ч"
                },
                {
                    "code": "335",
                    "name": "Метр на секунду в квадрате",
                    "shortName": "м/с2",
                    "codeName": "М/С2"
                },
                {
                    "code": "349",
                    "name": "Кулон на килограмм",
                    "shortName": "Кл/кг",
                    "codeName": "КЛ/КГ"
                },
                {
                    "code": "499",
                    "name": "Килограмм в секунду",
                    "shortName": "кг/с",
                    "codeName": "КГ/С"
                },
                {
                    "code": "533",
                    "name": "Тонна пара в час",
                    "shortName": "т пар/ч",
                    "codeName": "Т ПАР/Ч"
                },
                {
                    "code": "596",
                    "name": "Кубический метр в секунду",
                    "shortName": "м3/с",
                    "codeName": "М3/С"
                },
                {
                    "code": "598",
                    "name": "Кубический метр в час",
                    "shortName": "м3/ч",
                    "codeName": "М3/Ч"
                },
                {
                    "code": "599",
                    "name": "Тысяча кубических метров в сутки",
                    "shortName": "103 м3/сут",
                    "codeName": "ТЫС М3/СУТ"
                },
                {
                    "code": "616",
                    "name": "Бобина",
                    "shortName": "боб",
                    "codeName": "БОБ"
                },
                {
                    "code": "625",
                    "name": "Лист",
                    "shortName": "л.",
                    "codeName": "ЛИСТ"
                },
                {
                    "code": "626",
                    "name": "Сто листов",
                    "shortName": "100 л.",
                    "codeName": "100 ЛИСТ"
                },
                {
                    "code": "630",
                    "name": "Тысяча стандартных условных кирпичей",
                    "shortName": "тыс станд. усл. кирп",
                    "codeName": "ТЫС СТАНД УСЛ КИРП"
                },
                {
                    "code": "641",
                    "name": "Дюжина (12 шт.)",
                    "shortName": "дюжина",
                    "codeName": "ДЮЖИНА"
                },
                {
                    "code": "657",
                    "name": "Изделие",
                    "shortName": "изд",
                    "codeName": "ИЗД"
                },
                {
                    "code": "683",
                    "name": "Сто ящиков",
                    "shortName": "100 ящ.",
                    "codeName": "100 ЯЩ"
                },
                {
                    "code": "704",
                    "name": "Набор",
                    "shortName": "набор",
                    "codeName": "НАБОР"
                },
                {
                    "code": "715",
                    "name": "Пара (2 шт.)",
                    "shortName": "пар",
                    "codeName": "ПАР"
                },
                {
                    "code": "730",
                    "name": "Два десятка",
                    "shortName": "20",
                    "codeName": "2 ДЕС"
                },
                {
                    "code": "732",
                    "name": "Десять пар",
                    "shortName": "10 пар",
                    "codeName": "ДЕС ПАР"
                },
                {
                    "code": "733",
                    "name": "Дюжина пар",
                    "shortName": "дюжина пар",
                    "codeName": "ДЮЖИНА ПАР"
                },
                {
                    "code": "734",
                    "name": "Посылка",
                    "shortName": "посыл",
                    "codeName": "ПОСЫЛ"
                },
                {
                    "code": "735",
                    "name": "Часть",
                    "shortName": "часть",
                    "codeName": "ЧАСТЬ"
                },
                {
                    "code": "736",
                    "name": "Рулон",
                    "shortName": "рул",
                    "codeName": "РУЛ"
                },
                {
                    "code": "737",
                    "name": "Дюжина рулонов",
                    "shortName": "дюжина рул",
                    "codeName": "ДЮЖИНА РУЛ"
                },
                {
                    "code": "740",
                    "name": "Дюжина штук",
                    "shortName": "дюжина шт",
                    "codeName": "ДЮЖИНА ШТ"
                },
                {
                    "code": "745",
                    "name": "Элемент",
                    "shortName": "элем",
                    "codeName": "ЭЛЕМ"
                },
                {
                    "code": "778",
                    "name": "Упаковка",
                    "shortName": "упак",
                    "codeName": "УПАК"
                },
                {
                    "code": "780",
                    "name": "Дюжина упаковок",
                    "shortName": "дюжина упак",
                    "codeName": "ДЮЖИНА УПАК"
                },
                {
                    "code": "781",
                    "name": "Сто упаковок",
                    "shortName": "100 упак",
                    "codeName": "100 УПАК"
                },
                {
                    "code": "796",
                    "name": "Штука",
                    "shortName": "шт",
                    "codeName": "ШТ"
                },
                {
                    "code": "797",
                    "name": "Сто штук",
                    "shortName": "100 шт",
                    "codeName": "100 ШТ"
                },
                {
                    "code": "798",
                    "name": "Тысяча штук",
                    "shortName": "тыс. шт; 1000 шт",
                    "codeName": "ТЫС ШТ"
                },
                {
                    "code": "799",
                    "name": "Миллион штук",
                    "shortName": "106 шт",
                    "codeName": "МЛН ШТ"
                },
                {
                    "code": "800",
                    "name": "Миллиард штук",
                    "shortName": "109 шт",
                    "codeName": "МЛРД ШТ"
                },
                {
                    "code": "801",
                    "name": "Биллион штук (Европа); триллион штук",
                    "shortName": "1012 шт",
                    "codeName": "БИЛЛ ШТ (ЕВР); ТРИЛЛ ШТ"
                },
                {
                    "code": "802",
                    "name": "Квинтильон штук (Европа)",
                    "shortName": "1018 шт",
                    "codeName": "КВИНТ ШТ"
                },
                {
                    "code": "820",
                    "name": "Крепость спирта по массе",
                    "shortName": "креп. спирта по массе",
                    "codeName": "КРЕП СПИРТ ПО МАССЕ"
                },
                {
                    "code": "821",
                    "name": "Крепость спирта по объему",
                    "shortName": "креп. спирта по объему",
                    "codeName": "КРЕП СПИРТ ПО ОБЪЕМ"
                },
                {
                    "code": "831",
                    "name": "Литр чистого (100%) спирта",
                    "shortName": "л 100% спирта",
                    "codeName": "Л ЧИСТ СПИРТ"
                },
                {
                    "code": "833",
                    "name": "Гектолитр чистого (100%) спирта",
                    "shortName": "Гл 100% спирта",
                    "codeName": "ГЛ ЧИСТ СПИРТ"
                },
                {
                    "code": "841",
                    "name": "Килограмм пероксида водорода",
                    "shortName": "кг H2О2",
                    "codeName": "КГ ПЕРОКСИД ВОДОРОДА"
                },
                {
                    "code": "845",
                    "name": "Килограмм 90%-го сухого вещества",
                    "shortName": "кг 90% с/в",
                    "codeName": "КГ 90 ПРОЦ СУХ ВЕЩ"
                },
                {
                    "code": "847",
                    "name": "Тонна 90%-го сухого вещества",
                    "shortName": "т 90% с/в",
                    "codeName": "Т 90 ПРОЦ СУХ ВЕЩ"
                },
                {
                    "code": "852",
                    "name": "Килограмм оксида калия",
                    "shortName": "кг К2О",
                    "codeName": "КГ ОКСИД КАЛИЯ"
                },
                {
                    "code": "859",
                    "name": "Килограмм гидроксида калия",
                    "shortName": "кг КОН",
                    "codeName": "КГ ГИДРОКСИД КАЛИЯ"
                },
                {
                    "code": "861",
                    "name": "Килограмм азота",
                    "shortName": "кг N",
                    "codeName": "КГ АЗОТ"
                },
                {
                    "code": "863",
                    "name": "Килограмм гидроксида натрия",
                    "shortName": "кг NaOH",
                    "codeName": "КГ ГИДРОКСИД НАТРИЯ"
                },
                {
                    "code": "865",
                    "name": "Килограмм пятиокиси фосфора",
                    "shortName": "кг Р2О5",
                    "codeName": "КГ ПЯТИОКИСЬ ФОСФОРА"
                },
                {
                    "code": "867",
                    "name": "Килограмм урана",
                    "shortName": "кг U",
                    "codeName": "КГ УРАН"
                }
            ]
            """;
    }
}
