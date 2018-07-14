let Calculator = require('../models/calculator')

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },

    indexPost: (req, res) => {
        let calculatorData = req.body.calculator;

        let calculator = new Calculator(calculatorData.leftOperand,
            calculatorData.rightOperand,
            calculatorData.operator);

        let result = calculator.calculate();

        res.render('home/index', {

            result: result,
            calculator: {
                leftOperand: "I am having so much fun!!!",
                rightOperand: "Do you???",
                operator: calculatorData.operator,
            },
        });
    },

};