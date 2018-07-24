function Calculator(leftOperand, rightOperand, operation) {
    this.left = Number(leftOperand);
    this.right = Number(rightOperand);
    this.op = operation;

    this.calculate = function () {
        let result = 0;
        switch (this.op) {
            case "+":
                result = this.left + this.right;
                break;
            case "-":
                result = this.left - this.right;
                break;
            case "*":
                result = this.left * this.right;
                break;
            case "/":
                result = this.left / this.right;
                break;
        }

        return result;
    }

}

module.exports = Calculator;