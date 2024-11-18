Feature: Calcular soma
  Como um usuário
  Quero somar dois números
  Para obter o resultado correto

  Scenario: Soma de números positivos
    Given os números 2 e 3
    When eu somar os números
    Then o resultado será 5
