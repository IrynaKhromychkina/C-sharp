namespace Dictionary
{
    class Dictionary
    {
        private string[] valueEnglish = new string[5];
        private string[] valueRussian = new string[5];
        private string[] valueUkrainian = new string[5];

        public Dictionary()
        {
            valueEnglish[0] = "книга"; valueRussian[0] = "book"; valueUkrainian[0] = "книга";
            valueEnglish[1] = "ручка"; valueRussian[1] = "pen"; valueUkrainian[1] = "ручка";
            valueEnglish[2] = "солнце"; valueRussian[2] = "sun"; valueUkrainian[2] = "сонце";
            valueEnglish[3] = "яблоко"; valueRussian[3] = "apple"; valueUkrainian[3] = "яблуко";
            valueEnglish[4] = "стол"; valueRussian[4] = "table"; valueUkrainian[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < valueEnglish.Length; i++)
                {
                    if (valueEnglish[i] == index)
                        return valueEnglish[i] + " - " + valueRussian[i] + " - " + valueUkrainian[i];

                    if (valueRussian[i] == index)
                        return valueRussian[i] + " - " + valueEnglish[i] + " - " + valueUkrainian[i];

                    if (valueUkrainian[i] == index)
                        return valueUkrainian[i] + " - " + valueRussian[i] + " - " + valueEnglish[i];
                }

                return string.Format("{0} - no translation found.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < valueEnglish.Length)
                    return valueEnglish[index] + " - " + valueRussian[index] + " - " + valueUkrainian[index];
                else
                    return "Attempt to access an array element out of the array bounds.";
            }
        }
    }
}
