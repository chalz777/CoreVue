const { CleanWebpackPlugin } = require("./node_modules/clean-webpack-plugin/dist/clean-webpack-plugin");

module.exports = {
    outputDir: "wwwroot",
    filenameHashing: false,
    "transpileDependencies": [
        "vuetify"
    ],
    configureWebpack: {
        //plugins: [
        //    new CleanWebpackPlugin(),
        //    new MiniCssExtractPlugin({
        //        filename: "css/[name].css"
        //    }),
        //],
        devtool: 'source-map'
    },
}