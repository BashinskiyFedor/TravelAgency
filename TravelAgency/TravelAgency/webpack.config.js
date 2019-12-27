"use strict";
const path = require('path');
const MiniCssExtractPlugin = require('mini-css-extract-plugin')

module.exports = {
    entry: { main: "./Client/index.ts" },
    output: {
        path: path.resolve(__dirname, './wwwroot/dist/'),
        filename: "bundle.js"
    },
    resolve: {
        extensions: [".tsx", ".ts", ".js", '.scss']
    },
    devServer: {
        contentBase: ".",
        host: "localhost",
        port: 9000
    },
    module: {
        rules: [
            {
                test: /\.tsx?$/,
                loader: "ts-loader",
                exclude: /node_modules/,
            },
            { test: /\.css$/, use: "development" ? ['style-loader', 'css-loader'] : [MiniCssExtractPlugin.loader, 'css-loader'] },
            {
                test: /\.scss$/,
                use: [
                    'style-loader',
                    MiniCssExtractPlugin.loader,
                    {
                        loader: 'css-loader',
                        options: { sourceMap: true }
                    }, {
                        loader: 'sass-loader',
                        options: { sourceMap: true }
                    }
                ]
            },
            { test: /\.(png|jpg|jpeg|gif|svg)$/, use: 'url-loader?limit=25000' }
        ]
    },
    plugins: [
        new MiniCssExtractPlugin({
            filename: "style/name.css"
        })

    ]
};