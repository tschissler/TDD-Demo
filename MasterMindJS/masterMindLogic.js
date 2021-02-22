class masterMindLogic {
    static receiveCode(level) {
        var code = "";
        for (let i = 0; i < 4; i++) {
            code += String.fromCharCode('A'.charCodeAt(0) + Math.random()*(level + 2));
        }
        return code;
    }
    

    static GetGuessFeedback(code, input) {
        return "GetGuessFeedback not implemented yet. Try to apply TDD practices and implement it now!";
    }
}

module.exports = masterMindLogic;