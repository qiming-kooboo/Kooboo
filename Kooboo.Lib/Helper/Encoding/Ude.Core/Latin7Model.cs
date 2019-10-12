//Copyright (c) 2018 Yardi Technology Limited. Http://www.kooboo.com
//All rights reserved.

namespace Ude.Core
{
    public class Latin7Model : GreekModel
    {
        private static readonly byte[] LATIN7_CHAR_TO_ORDER_MAP = new byte[]
        {
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            254,
            255,
            255,
            254,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            252,
            252,
            252,
            252,
            252,
            252,
            252,
            252,
            252,
            252,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            82,
            100,
            104,
            94,
            98,
            101,
            116,
            102,
            111,
            187,
            117,
            92,
            88,
            113,
            85,
            79,
            118,
            105,
            83,
            67,
            114,
            119,
            95,
            99,
            109,
            188,
            253,
            253,
            253,
            253,
            253,
            253,
            72,
            70,
            80,
            81,
            60,
            96,
            93,
            89,
            68,
            120,
            97,
            77,
            86,
            69,
            55,
            78,
            115,
            65,
            66,
            58,
            76,
            106,
            103,
            87,
            107,
            112,
            253,
            253,
            253,
            253,
            253,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            255,
            253,
            233,
            90,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            253,
            74,
            253,
            253,
            253,
            253,
            253,
            253,
            247,
            248,
            61,
            36,
            46,
            71,
            73,
            253,
            54,
            253,
            108,
            123,
            110,
            31,
            51,
            43,
            41,
            34,
            91,
            40,
            52,
            47,
            44,
            53,
            38,
            49,
            59,
            39,
            35,
            48,
            250,
            37,
            33,
            45,
            56,
            50,
            84,
            57,
            120,
            121,
            17,
            18,
            22,
            15,
            124,
            1,
            29,
            20,
            21,
            3,
            32,
            13,
            25,
            5,
            11,
            16,
            10,
            6,
            30,
            4,
            9,
            8,
            14,
            7,
            2,
            12,
            28,
            23,
            42,
            24,
            64,
            75,
            19,
            26,
            27,
            253
        };

        public Latin7Model() : base(Latin7Model.LATIN7_CHAR_TO_ORDER_MAP, "ISO-8859-7")
        {
        }
    }
}