<?php

namespace CalculatorBundle\Entity;

class Calculator
{
    /**
     * @var float
     */
    public $leftOperand;

    /**
     * @var float
     */
    public $rightOperand;

    /**
     * @var string
     */
    public $operator;

    /**
     * Calculator constructor.
     */
    public function __construct()
    {
    }

    /**
     * @return float
     */
    public function getLeftOperand(): float
    {
        return $this->leftOperand;
    }

    /**
     * @param float $leftOperand
     */
    public function setLeftOperand(float $leftOperand): void
    {
        $this->leftOperand = $leftOperand;
    }

    /**
     * @return float
     */
    public function getRightOperand(): float
    {
        return $this->rightOperand;
    }

    /**
     * @param float $rightOperand
     */
    public function setRightOperand(float $rightOperand): void
    {
        $this->rightOperand = $rightOperand;
    }

    /**
     * @return string
     */
    public function getOperator(): string
    {
        return $this->operator;
    }

    /**
     * @param string $operator
     */
    public function setOperator(string $operator): void
    {
        $this->operator = $operator;
    }


}