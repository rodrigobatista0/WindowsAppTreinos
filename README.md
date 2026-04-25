# Treinos — Windows Forms App (.NET Framework)


## Descrição

Aplicação Windows Forms em C# para gerir treinos de manutenção.  
Permite registar treinos (corrida, caminhada ou misto), visualizá-los numa ListView e obter estatísticas.

---

## Estrutura do Projeto

```
TreinosJC/
│
├── TreinoJC.cs          → Classe que modela um treino
├── FormDetalhes.cs      → 1º form — define quantos treinos gerir
├── Form1.cs             → Form principal — ListView + operações
└── Program.cs           → Ponto de entrada da aplicação
```

---

## Classe `TreinoJC`

| Membro | Descrição |
|---|---|
| `distancia` | Distância em Km (double, privado) |
| `duracao` | Duração em segundos (int, privado) |
| `tipoTreino` | Tipo: Corrida, Caminhada ou Misto (string, privado) |
| `p_Distancia` | Property com validação (> 0) |
| `p_Duracao` | Property com validação (> 0) |
| `p_TipoTreino` | Property com validação dos tipos aceites |
| `VelocidadeMedia()` | Devolve velocidade em m/s |
| `ComparaDuracao(int, out, out)` | Compara duração, devolve dist. e vel. ou -1 |
| `ComparaDuracao(string)` | Overload — compara tipo, devolve vel. ou -1 |
| `ToString()` | Formato: `"Misto: 10.0 (1.0 horas)"` |
| `CompararVelocidade(TreinoJC)` | Compara vel. média entre dois objetos |
| `TreinoJC()` | Default constructor: 10.0 Km, 3600s, Misto |
| `TreinoJC(double, int, string)` | Non-default constructor com validação |

### Fórmula da Velocidade Média
```
Velocidade (m/s) = distância (m) / duração (s)
                 = distância × 1000 / duração

Exemplo: 10 Km, 65 min → 10000 / 3900 = 2.564 m/s
```

---

## Funcionamento da Aplicação

### Fluxo de execução
```
Program.cs
    │
    ▼
FormDetalhes → utilizador define nº de treinos (ex: 5)
    │
    ▼
Form1 → array TreinoJC[5] criado
    │
    ├─ Adicionar   → cria objeto TreinoJC → guarda no array
    ├─ Mostrar     → percorre array → preenche ListView
    ├─ Contagem    → conta treinos por tipo
    └─ Média       → calcula média da duração em HH:MM
```

### Form Principal (Form1)

| Controlo | Função |
|---|---|
| `txtDist` | Inserir distância em Km |
| `txtDur` | Inserir duração em minutos |
| `cmbTipo` | Selecionar tipo de treino |
| `btnAdc` | Adicionar treino ao array |
| `btnMst` | Preencher ListView com os treinos |
| `btnCount` | Mostrar contagem por tipo |
| `btnMedia` | Mostrar média da duração (HH:MM) |
| `lsvInfo` | ListView com colunas: Tipo, Distância, Duração |

---

## Como Executar

1. Abrir o projeto no **Visual Studio**
2. Compilar com **Ctrl + Shift + B**
3. Executar com **F5**
4. No `FormDetalhes` — introduzir o número de treinos a gerir
5. No `Form1` — adicionar treinos e usar os botões

---

## Requisitos

- Visual Studio 2019 ou superior
- .NET Framework 4.7.2+
- Windows

---

## Conceitos Aplicados

- Programação Orientada a Objetos (POO)
- Classes, campos privados e properties
- Constructors (default e non-default)
- Overload de métodos
- Parâmetros `out`
- Arrays de objetos
- Windows Forms (ListView, ComboBox, MessageBox)
- Comunicação entre Forms
