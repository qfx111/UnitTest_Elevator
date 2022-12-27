using System;
using System.Collections.Generic;

namespace ElevatorProject
{
    public class Elevator
    {
        public int MaxWeightAllowed;
        public int CurrentWeight;        

        /// <summary>
        /// Contructor: Инициализирует максимальную высоту и текущий вес лифта
        /// </summary>
        public Elevator(int MaxHeight)
        {
            MaxWeightAllowed = MaxHeight;
            CurrentWeight = 0;            
        }

        /// <summary>
        /// Добавляет вес юзера, который зашёл в лифт
        /// </summary>
        /// <param name="User"></param>
        public void InUser(Employee User)
        {
            CurrentWeight += User.Weight;            
        }

        /// <summary>
        /// Вычитает вес юзера из общего веса
        /// </summary>
        /// <param name="User"></param>
        public void OutUser(Employee User)
        {
            CurrentWeight -= User.Weight;            
            if (CurrentWeight < 0) CurrentWeight = 0;
        }

        /// <summary>
        /// Проверяет - Достигнут ли максимально-дозволенный вес в лифте
        /// </summary>
        /// <returns>true если лифт достиг максимальный дозволенный вес, false если нет</returns>
        public bool CheckMaxWeightAllowedReached()
        {
            return CurrentWeight >= MaxWeightAllowed;
        }

        /// <summary>
        /// Проверяет -- есть ли у сотрудника доступ к vip секции, и в лифте кто-то есть (только для сотрудников)
        /// </summary>
        /// <param name="User">Сотрудник, который хочет попасть в vip секцию</param>
        /// <returns>true если может попасть в vip секцию, false если нет</returns>
        public bool GoToVipSection(Employee User)
        {
            return  (CurrentWeight > 0 && User.IsExecutive);
        }
    }

    public class Employee
    {
        public bool IsExecutive { get; set; }
        public int Weight { get; set; }
    }
}
