namespace NeuralNetworks.Model
{
    /// <summary>
    /// Режимы работы памяти
    /// </summary>
    enum MemoryMode
    {
        /// <summary>
        /// Чтение
        /// </summary>
        GET,

        /// <summary>
        /// Запись
        /// </summary>
        SET
    }

    /// <summary>
    /// Тип нейрона (классификация по слою)
    /// </summary>
    enum NeuronType
    {
        /// <summary>
        /// Нейрон скрытого слоя
        /// </summary>
        Hidden,

        /// <summary>
        /// Нейрон выходного слоя
        /// </summary>
        Output
    }

    /// <summary>
    /// Режимы работы нейросети
    /// </summary>
    enum NetworkMode
    {
        /// <summary>
        /// Обучение
        /// </summary>
        Train,

        /// <summary>
        /// Тестирование
        /// </summary>
        Test,

        /// <summary>
        /// Полезная работа
        /// </summary>
        Run
    }
}