# Chapter
Api feita com ASP NET CORE 5

API tem no total 5 endpoints, como:
- Criação de um livro
- Atualização de um livro
- Busca de um livro por ID
- Mostrar todos os livros 
- Deletando um livro

## Criação de um livro

`POST /api/livros - FORMATO DA REQUISÃO - STATUS 201`

```json
{
	"titulo": "Harry Potter",
  "quantidadepaginas": 300,
  "disponivel" true,
}
```

`FORMATO DA RESPOSTA`

```json
No body
```
## Atualização de um livro

`PUT /api/livros/id - FORMATO DA REQUISÃO - STATUS 201`

```json
{
	"titulo": "Percy Jackson",
  "quantidadepaginas": 200,
  "disponivel" false,
}
```

`FORMATO DA RESPOSTA`

```json
{
	"titulo": "Percy Jackson",
  "quantidadepaginas": 200,
  "disponivel" false,
}
```

## Buscar um livro por id

`GET /api/livros/id - FORMATO DA REQUISÃO - STATUS 200`

```json
No Body
```

`FORMATO DA RESPOSTA`

```json
{
	"titulo": "Percy Jackson",
  "quantidadepaginas": 200,
  "disponivel" false,
}
```

## Buscar todos os livros

`GET /api/livros - FORMATO DA REQUISÃO - STATUS 200`

```json
No Body
```

`FORMATO DA RESPOSTA`

```json
[
{
	"titulo": "Percy Jackson",
  "quantidadepaginas": 200,
  "disponivel" false,
}
]
```

## Deletando um livro

`DELETE /api/livros/id - FORMATO DA REQUISÃO - STATUS 201`

```json
No Body
```

`FORMATO DA RESPOSTA`

```json
No Body
```
