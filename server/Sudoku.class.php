<?php
class Sudoku{
    private $win = false;
    private $puzzle = array();

    public function __construct(){
        //Reads puzzles.txt and selects a random line.
        //Each line represent a Sudoku puzzle with 81 chars.
        $f_contents = file("puzzles.txt");
        $line = $f_contents[array_rand($f_contents)];
        $data = $line;
        //Splits the string in substrings of 9 elements.
        $strRow = str_split($data, 9);

        //Loops through the substrings and copies their value in the array Puzzle.
        foreach (range(0,8) as $row) {
            //Splits the substring of 9 elements in substrings of 1 element.
            $strColumns = str_split($strRow[$row]);
            foreach (range(0,8) as $col) {
                $this->puzzle[$row][$col] = $strColumns[$col];
            }
        }
    }

    public function sendPuzzleValues(){
        $values = "";
        for($row = 0; $row < 9; ++$row)  {
            for($col = 0; $col < 9; ++$col) {
                if ($row != 8 or $col != 8)
                    $values .= $this->puzzle[$row][$col] . ",";
                else
                    $values .= $this->puzzle[$row][$col];
            }
        }
        return $values;
    }
    
    public function receivePuzzle($puzzleClient){
        $indexStr = 0;
        $newValues = str_split($puzzleClient);
        for ($row = 0; $row < 9; ++$row){
            for ($col = 0; $col < 9; ++$col){
                $this->puzzle[$row][$col] = $newValues[$indexStr];
                $indexStr++;
            }
        }
    }


    /*  Recibe el las posiciones de la celda
        fila (x) y columna (y) y el valor (v)  */
    public function receiveValue($x, $y, $v){
        $this->puzzle[$x][$y] = $v;
    }

    public function checkRow ($rowNum){
        $isValid = false;
        $rowCount = 0;
        foreach (range(0,8) as $col) {
            $rowCount += $this->puzzle[$rowNum][$col];
        }
        if ($rowCount == 45){
            $isValid = true;
        }
        return $isValid;
    }

    public function checkColumn ($columnNum){
        $isValid = false;
        $columnCount = 0;
        foreach (range(0,8) as $row) {
            $columnCount += $this->puzzle[$row][$columnNum];
        }
        if ($columnCount == 45){
            $isValid = true;
        }
        return $isValid;
    }

    public function checkSubmatrix($submatrixNum){
        $isValid = false;
        $submatrixCount = 0; 
        $indexRow = 0;
        $indexCol = 0;
        //Checks the value of submatrixNum to determinate the row index
        if ($submatrixNum >= 3 and $submatrixNum < 6){
            $indexRow = 3;
        }
        elseif ($submatrixNum >= 6){
            $indexRow = 6;
        }
        //Checks the value of submatrixNum to determinate the column index
        if ($submatrixNum % 3 == 1){
            $indexCol = 3;
        }
        elseif ($submatrixNum % 3 == 2){
            $indexCol = 6;
        }
        for ($row = $indexRow; $row < $indexRow + 3; ++$row){
            for ($col = $indexCol; $col < $indexCol + 3; ++$col){
                $submatrixCount += $this->puzzle[$row][$col];
            }
        }
        if ($submatrixCount == 45){
            $isValid = true;
        }
        return $isValid;
    }

    public function winGame(){
        $winArray = array();
        $win = true;
        for ($i = 0; $i < 9; ++$i){
            $winArray[0][$i] = $this->checkRow($i);
            $winArray[1][$i] = $this->checkColumn($i);
            $winArray[2][$i] = $this->checkSubmatrix($i);
        }
        for ($i = 0; $i < 9; ++$i){
            if ($winArray[0][$i] == false)
                $win = false;
            if ($winArray[1][$i] == false)
                $win = false;
            if ($winArray[2][$i] == false)
                $win = false;
        }
        return $win;
    }
}
//$sudoku = new Sudoku;
//$sudoku->receivePuzzle("593674128276891543148352796852413967914726835637589412389245671721968354465137289");
//$sudoku->checkSubmatrix(0);
?>