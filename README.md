# aws-lambda.cs.sam

🐦🐦🐦 Terraformで`AWS Lambda`をプロビジョニングするサンプルプロジェクトです。  
C#で書かれています。  

![成果物](./docs/img/fruit.gif)  

## CI/CD設定

以下の値をリポジトリシークレットに設定します。  

| Name | Value |
| --- | --- |
| AWS_ACCESS_KEY_ID | AWSアクセスキー |
| AWS_SECRET_ACCESS_KEY | AWSシークレットアクセスキー |
| AWS_REGION | AWSリージョン |
| SAMCONFIG_TOML | `samconfig.toml`の内容をBASE64でエンコードしたデータ |

※`samconfig.toml`の内容をBASE64でエンコードする理由はリポジトリシークレットは原則として構造化されたデータを扱えないためです。  

`main`ブランチにマージすると、`AWS Lambda`のプロビジョニングが実行されます。  

## ローカルからのデプロイ

GitHub Actionsを用いない場合です。  
以下のディレクトリで`AWS SAM`コマンドを実行します。  

```shell
sam build --use-container
sam deploy --guided
```

## ローカル実行

開発目的でローカルで実行するには、以下のコマンドを実行します。  

```shell
sam build --use-container
sam local start-api

# リクエストの送信
sam local invoke
```

## サンプルコード

以下のパスにアクセスします。  

* /Prod (GET)
* /Prod (POST)
* /Prod (PUT)
* /Prod (DELETE)

`Hello ★メソッド名★`というレスポンスが返ってきます。  

## 環境情報

| Name | Version |
| --- | --- |
| AWS CLI | 2.9.17 |
| AWS SAM CLI | 1.73.0 |
| Docker | 20.10.17 |

## イロイロ情報

### AWS CLIのインストール

[公式ページ](https://docs.aws.amazon.com/ja_jp/cli/latest/userguide/install-cliv2.html)の説明に沿って、インストールします。  

### Dockerのインストール

[公式ページ](https://docs.docker.com/get-docker/)の説明に沿って、インストールします。  

### AWS SAM CLI のインストール

[公式ページ](https://docs.aws.amazon.com/ja_jp/serverless-application-model/latest/developerguide/install-sam-cli.html)の説明に沿って、インストールします。  
AWS SAM CLIとは、Serverless Application Model の略称でAWS Lambdaのローカル実行環境を提供するツールです。  

---

前提として、`AWS CLI`がインストールされている必要があります。  
`AWS CLI`のインストール方法は、[公式ページ](https://docs.aws.amazon.com/ja_jp/cli/latest/userguide/install-cliv2.html)を参照してください。  

### 削除

以下のコマンドで、AWS SAMで構築したリソースを削除できます。  

```shell
sam delete
```
