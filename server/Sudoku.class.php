<?php
class Sudoku{
    private $win = false;
    private $puzzle = array();

    public function __construct(){
     foreach (range(0,8) as $row) {
            foreach (range(0,8) as $col) {
                $this->puzzle[$row][$col] = 1;
            }
        }   
    }

    public function sendPuzzleValues(){
        $values = "";
        foreach (range(0,8) as $row) {
            foreach (range(0,8) as $col) {
                $values .= $this->puzzle[$row][$col] . ",";
            }
            $values .= "|";
        }
        return $values;
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
            echo $rowCount;
            
        }
        return $isValid;
    }

    public function checkColumn ($columnNum){
        $isValid = false;
        $columnCount = 0;
        foreach (range(0,8) as $row) {
            $rowCount += $this->puzzle[$row][$columnNum];
        }
        if ($columnCount == 45){
            $isValid = true;
            echo $columnCount;
            
        }
        return $isValid;
    }

}
$sudoku = new Sudoku;
$sudoku->sendPuzzleValues();
?>