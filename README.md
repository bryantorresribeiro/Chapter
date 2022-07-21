# Chapter
Api feita com ASP.NET CORE 5

## Procedimentos:
- Faça um clone do repositorio
- Utilize o Visual Studio Community 
- Execute dentro do VSCODE a API


API tem no total 5 endpoints, como:
- Criação de um livro
- Atualização de um livro por ID
- Buscar um livro por ID
- Mostrar todos os livros 
- Deletar um livro por ID

## Criação de um livro

`POST /api/livros - FORMATO DA REQUISÃO - STATUS 201`

```json
{
  "titulo": "Harry Potter",
  "quantidadepaginas": 300,
  "disponivel" true
}
```

`FORMATO DA RESPOSTA`

```json
"No body"
```
## Atualização de um livro

`PUT /api/livros/ID - FORMATO DA REQUISÃO - STATUS 201`

```json
{
  "titulo": "Percy Jackson",
  "quantidadepaginas": 200,
  "disponivel" false
}
```

`FORMATO DA RESPOSTA`

```json
{
  "titulo": "Percy Jackson",
  "quantidadepaginas": 200,
  "disponivel" false
}
```

## Buscar um livro por ID

`GET /api/livros/ID - FORMATO DA REQUISÃO - STATUS 200`

```json
"No Body"
```

`FORMATO DA RESPOSTA`

```json
{
  "titulo": "Percy Jackson",
  "quantidadepaginas": 200,
  "disponivel" false
}
```

## Buscar todos os livros

`GET /api/livros - FORMATO DA REQUISÃO - STATUS 200`

```json
"No Body"
```

`FORMATO DA RESPOSTA`

```json
[
{
  "titulo": "Percy Jackson",
  "quantidadepaginas": 200,
  "disponivel" false
}
]
```

## Deletar um livro por ID

`DELETE /api/livros/ID - FORMATO DA REQUISÃO - STATUS 201`

```json
"No Body"
```

`FORMATO DA RESPOSTA`

```json
"No Body"
```
