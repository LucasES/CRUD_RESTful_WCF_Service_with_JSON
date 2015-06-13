var ControleNutricional = angular.module("ControleNutricional", ['ngRoute', 'ngResource']).
    config(function ($routeProvider) {
        $routeProvider.
            when('/', { controller: IndexControl, templateUrl: '/pages/home.html' }).
            when('/cadastrar', { controller: CadastroAlimentoControl, templateUrl: '/pages/cadastrarAlimento.html' }).

            otherwise({ redirectTo: '/' });
    });

ControleNutricional.factory('ControleNutricional', function ($resource) {
    return $resource('---caminho---', { Id: '@id' }, { update: { method: 'PUT' } });
});

var IndexControl = function ($scope, $location, $routeParams) {
    $scope.message = "Fulano";

};
var CadastroAlimentoControl = function ($scope, $location, $routeParams) {
    //pegar grupos de alimentos do banco
    //receber os parametros do form e salvar
};
