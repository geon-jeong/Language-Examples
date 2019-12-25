
//Install Rust (Mac)
//it may need: chmod 666 .profile 
$curl https://sh.rustup.rs -sSf | sh
$source $HOME/.cargo/env
$rustc --version
$rustup update

//Uninstall
$rustup self uninstall


//Hello World
$rustc main.rs
$./main

// Cargo Hello World
$cargo new hello_cargo --bin
$cd hello_cargo
#cargo build
#cargo check
#cargo run
