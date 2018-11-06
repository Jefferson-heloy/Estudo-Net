"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var DataServices = /** @class */ (function () {
    function DataServices(http) {
        this.http = http;
        this.produtos = [
            {
                titulo: "Primeiro produto",
                preco: 10
            }, {
                titulo: "Segundo produto",
                preco: 20
            }
        ];
    }
    return DataServices;
}());
exports.DataServices = DataServices;
//# sourceMappingURL=dataServices.js.map