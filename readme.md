## Работа основного алгоритма программы
1. На вход принимаем массив данных (array)
2. Создаём второй массив (newarray) с кол-м элементов равным их кол-ву в первом массиве.
3. Создаём переменную (счётчик) для следующего цикла, равную 0.
4. Создаём цикл, выполняющийся, пока его счетчик не станет равным кол-ву элементов массива.
5. С помощью оператора .Length измеряем число символов (длинну) элемента массива
в ячейке массива с номером, равным номеру шага цикла. 
6. Если верно условие, что длинна элемента массива меньше или равна 3м, записываем этот элемент во второй массив, в ячейку с номером, равным шагу цикла. Увеличиваем счетчик цикла и переходим к следующему шагу.
7. Если условие не выполняется, увеличиваем счетчик цикла и переходим к следующему шагу.
8. Когда цикл завершает работу, отдаём на выход получившийся массив. 